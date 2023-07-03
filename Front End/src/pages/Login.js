import React, { useEffect } from 'react';
import useForm from "../hooks/useForm";
import axios from 'axios';
import { useNavigate, Link } from 'react-router-dom';
import '../styles/Login.css';
import 'mdb-react-ui-kit/dist/css/mdb.min.css';
import logo from '../images/logo.png';
import {
  MDBBtn,
  MDBContainer,
  MDBRow,
  MDBCol,
  MDBInput
}
from 'mdb-react-ui-kit';

const getFreshModel = () => ({
  email: '',
  password: '',
});

 function Login() {
  const navigate = useNavigate();

  const {
    values,
    setValues,
    errors,
    setErrors,
    handleInputChange,
  } = useForm(getFreshModel);

  useEffect(() => {
    
    setValues(getFreshModel());
    setErrors({});
  }, []);

  const handleLogin = (e) => {
    e.preventDefault();
    console.log(values)
   
    if (validate()) {
      
      axios
        .post('https://localhost:7021/api/Auth/login', values)
        .then((res) => {
          console.log(res.data)
          
          const { token, roleId ,userName, userId } = res.data;
 
          localStorage.setItem('token', token);      
          localStorage.setItem('roleId', roleId);
          localStorage.setItem('userName', userName);
          localStorage.setItem('userId', userId);          

          // Redirect based on role ID
          if (roleId === 1) {
            navigate('/adminHome');
          } else if (roleId === 2) {
            navigate('/UserHome');
          } else {
            
            navigate('/login'); 
          }
        })
        .catch((err) => console.log('Login failed', err));
    }
  };

  const validate = () => {
    let temp = {};
    temp.email = /\S+@\S+\.\S+/.test(values.email)
      ? ''
      : 'Email is not valid.';
    temp.password = values.password !== '' ? '' : 'This field is required.';
    setErrors(temp);
    return Object.values(temp).every((x) => x === '');
  };
  return (
    <MDBContainer className="my-5 gradient-form" style={{backgroundColor:"#edebeb"}}>

      <MDBRow>

        <MDBCol md='6' className="container-md">
          <div className="d-flex flex-column ms-5">

            <div className="text-center">
              <img src={logo}
                style={{width: '185px'}} alt="logo" />
              <h4 className="mt-1 mb-5 pb-1">Welcome to Food Bites</h4>
            </div>

            <h5 className="text-danger">Sign into your account</h5>

            <form onSubmit={handleLogin}> 
            <MDBInput wrapperClass='mb-4' label='Email address' id='form1' type='email'
            name='email'value={values.email} onChange={handleInputChange} error={errors.email}/>

            <MDBInput wrapperClass='mb-4' label='Password' id='form2' type='password'
             name='password' value={values.password} onChange={handleInputChange} error={errors.password}/>


            <div className="text-center pt-1 mb-4 pb-1">
              <MDBBtn className="mb-3 w-100" color='dark'>Sign in</MDBBtn>
              <a className="text-muted" href="#!">Forgot password?</a>
            </div>
            </form>

            <div className="d-flex flex-row align-items-center justify-content-center pb-2 mb-2">
              <p className="mb-0">Don't have an account?</p>
              <MDBBtn outline className='mx-2' color='danger' href='/register'>
                Create New
              </MDBBtn>             
                         
            </div>
            <p className='text-center'> 
            <Link to = "/"> Go back to homepage </Link>
            </p>
          </div>

        </MDBCol>

      </MDBRow>
      </MDBContainer> 
   
  );
}
export default Login;