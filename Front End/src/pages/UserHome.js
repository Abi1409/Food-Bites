import React from 'react';
import Footer from '../components/Footer'
import {Navbar, Container, Nav, Row, Col, Button, Image} from 'react-bootstrap';
import { MdFastfood, MdPowerSettingsNew, MdDeliveryDining, MdMobileFriendly, MdVerified } from 'react-icons/md';
import {IoMdContact} from 'react-icons/io';
import style from '../styles/Styles.module.css';
import food2 from '../images/food2.png';
import { Link } from 'react-router-dom';

function UserHome()  {
  return (
    
  <div>
        
    <Navbar expand="md" bg="dark" variant="dark">
      <Container>
      <Link to="/" style={{textDecoration: 'none'}}>            
            <Navbar.Brand  className="justify-content-end "><MdFastfood size = '40px'/>Food Bites</Navbar.Brand>
           </Link>        
        <Navbar.Toggle><IoMdContact size='30px'/> </Navbar.Toggle>
       
        <Navbar.Collapse  className="justify-content-between ">
          <div>          
        <Nav>       
        <Nav.Link href="/menu">Menu</Nav.Link>
        <Nav.Link href="/contact">Contact</Nav.Link>
        <Nav.Link href="/myCart">Cart</Nav.Link>
        </Nav>
        </div>
        
        <Link to="/" style={{textDecoration: 'none'}}>   
         <Navbar.Brand className="mx-auto" style={{fontSize:"15px"}}>< MdPowerSettingsNew size = '15px' />Logout</Navbar.Brand>      
        </Link>
        
        </Navbar.Collapse>
      </Container>
    </Navbar>
      
    <Container className="rounded-8 mb-5 mt-5 p-4" style={{backgroundColor:"#edebeb"}}>
      <Row>
        <Col className='p-5'>
          <h3>Welcome User!!</h3>
          <div>
            <h2 className={style.RedHeading}> Satisfy your cravings with Ease! </h2>
            <h5 className ="p-2"> The Ultimate Food delivery App </h5>
            <p className ="p-2"> FoodBites is here to satisfy your hunger with a few simple taps on your smartphone.
          With FoodBites, you can enjoy a wide variety of cuisines from the comfort of your own home. </p>

          <Link to="/Menu"> <Button variant="outline-danger">Order Here</Button></Link>
          </div>
       
        </Col>
        <Col xs={6} className="align-items-center">
      
        <Row className="" >
          <Image src={food2} roundedCircle className='m-3 h-50 w-50' /> 
        </Row>
        </Col>
        
      </Row>
      </Container>
    
      <div className={style.BlackContainer}>      
      <Row>
        <Col className = "text-center p-5" ><MdMobileFriendly  size = '30px'/>
        <h3> Easy to order</h3>
        <p> Ordering food has never been easier. our friendly interface allows you to navigate through menus and
           customize your orders. With just a few taps, you'll hava a delectable meal on its way to you.</p>
        </Col >
        <Col className = "text-center p-5"><MdDeliveryDining  size = '30px'/>
        <h3> Fastest Delivery </h3>
        <p> We understand that hunger stands for no one. Thats why FoodBites is comitted to delivering your 
          favourite dishes at lightning speed right to your doorstep.
        </p>
        </Col>
        <Col className = "text-center p-5"><MdVerified  size = '30px'/>
        <h3> Best Quality </h3>
        <p >Taste the difference with uncompromising quality, exquisite flavors, superior incredients. And to a
          celebration of flavor with unleashing the essence of premium quality.
        </p>
        </Col>
      </Row>
      </div>
     
      <Footer/>   
    
  </div>        
  );
}
export default UserHome;