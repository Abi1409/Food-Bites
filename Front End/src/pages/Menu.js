import React from 'react'
import {Navbar, Container} from 'react-bootstrap';
import { MdFastfood} from 'react-icons/md';

function Menu() {
  return (
    <div>
        
        <Navbar expand="md" bg="dark" variant="dark">      <Container>
        <Navbar.Brand style={{textDecoration: 'none'}} className="justify-content-end "><MdFastfood size = '40px'/>Food Bites</Navbar.Brand>
        </Container>  
    </Navbar>
    
    </div>    
  );
}
export default Menu;