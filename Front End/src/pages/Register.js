import React, {useState} from 'react';
import logo from '../images/logo.png';
import '../styles/Login.css';
import 'mdb-react-ui-kit/dist/css/mdb.min.css';
import axios from 'axios';
import { Link } from 'react-router-dom';
import { MDBBtn,  MDBContainer,MDBRow, MDBCol, MDBInput}  from 'mdb-react-ui-kit';
import {  toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

function Register() {
  const[username, setUsername] = useState('');
  const[email, setEmail] = useState('');
  const[password, setPassword] = useState('');
  const[confirmPassword, setConfirmPassword] = useState('');
  const[contact, setContact] = useState('');

  const handleRegister = async (e) =>{

    e.preventDefault();

    try{
      const response = await axios.post('https://localhost:7021/api/Auth/Registration',{
          username,
          email,
          password,
         confirmPassword,
         contact,
         roleId:2
      });
    
    toast.success("Registered successfully!");
    console.log(response.data);

    setUsername('');
    setEmail('');
    setPassword('');
    setConfirmPassword('');
    setContact('');

  } 
  catch (error){
     console.error(error);
  }
};
const [validated, setValidated] = useState(false);
const handleSubmit = (event) => {
  const form = event.currentTarget;
  if (form.checkValidity() === false) {
    event.preventDefault();
    event.stopPropagation();
  }
  setValidated(true);};
  return (
    <MDBContainer className="my-5 gradient-form" style={{backgroundColor:"#edebeb"}}>

      <MDBRow>

        <MDBCol md='6' className="container-md">
          <div className="d-flex flex-column ms-5">

            <div className="text-center">
              <img src={logo}
                style={{width: '185px'}} alt="logo" />
              <h4 className="mt-1 mb-3 pb-1">Welcome to Food Bites</h4>
            </div>

            <h5 className='text-center text-danger'>Registration Form</h5>

            <form onSubmit={handleRegister}>
            <MDBInput wrapperClass='mb-4' label='UserName' id='form1' type='text' value={username}
            onChange={(e) => setUsername(e.target.value)}/>

            <MDBInput wrapperClass='mb-4' label='Email address' id='form2' type='email' value={email}
            onChange={(e) => setEmail(e.target.value)}/>

            <MDBInput wrapperClass='mb-4' label='Password' id='form3' type='password' value={password}
             onChange={(e) => setPassword(e.target.value)}/>

            <MDBInput wrapperClass='mb-4' label='Confirm Password' id='form4' type='password' value={confirmPassword}
             onChange={(e) => setConfirmPassword(e.target.value)}/>

            <MDBInput wrapperClass='mb-4' label='Contact' id='form5' type='contact' value={contact}
             onChange={(e) => setContact(e.target.value)}/>


            <div className="text-center pt-1 mb-2 pb-1">
              
              <MDBBtn className="mb-3 w-100" color='dark' onClick={handleSubmit}>Register</MDBBtn>
              
              <p className='text-center mt-0'> 
            <Link to = "/"> Go back to homepage </Link>
            </p>
            </div>
            
            </form>            

            <div className="d-flex flex-row align-items-center justify-content-center pb-4 mb-4">
              <p className="mb-0 mt-0">Already Registered User?</p>
              <MDBBtn outline className='mx-2' color='danger' href='/login'>
                Login
              </MDBBtn>
            </div>
            
          </div>
        </MDBCol>       
      </MDBRow>      
     </MDBContainer>
  );
}
export default Register;