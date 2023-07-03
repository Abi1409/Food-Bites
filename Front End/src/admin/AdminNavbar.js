import  React from 'react';
import { Link } from 'react-router-dom';
import {IoMdContact} from 'react-icons/io';
import {Navbar, Container, Nav} from 'react-bootstrap';
import { MdFastfood, MdPowerSettingsNew} from 'react-icons/md';

function AdminNav(){
    return (
        <div>
        
        <Navbar expand="md" bg="dark" variant="dark">
              <Container>
                <Navbar.Brand className="mx-auto"><MdFastfood size = '40px' /> Food Bites</Navbar.Brand>
                <Navbar.Toggle><IoMdContact size='30px'/> </Navbar.Toggle>
                
                <Navbar.Collapse  className="justify-content-between ">
               
                <div className="px-5 my-auto">
                <Nav>
                <Nav.Link href="/itemList">ItemList</Nav.Link>
                <Nav.Link href="/userlist">UserList</Nav.Link>
                <Nav.Link href="/orderlist">orderList</Nav.Link>
                </Nav> 
                </div>                              

                <Link to="/" style={{textDecoration: 'none'}}>   
                <span className='flex-end'><Navbar.Brand className="mx-auto" style={{fontSize:"15px"}}>< MdPowerSettingsNew size = '15px' />Logout</Navbar.Brand></span>      
                </Link>
                
                </Navbar.Collapse>
              </Container>
            </Navbar>

            </div>

    );
}
export default AdminNav;