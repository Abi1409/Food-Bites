import React from 'react';
import { MDBFooter } from 'mdb-react-ui-kit';
import { Container, Row, Col, ListGroup, ListGroupItem } from "reactstrap";
import { Link } from "react-router-dom";
import style from '../styles/Footer.css';

const quickLinks = [
  {
    path: "/",
    display: "Home",
  },
  {
    path: "#",
    display: "Privacy Policy",
  },
  {
    path: "/menu",
    display: "Menu Listing",
  },
  {
    path: "/contact",
    display: "Contact",
  },
];

const Footer = () => {
  const date = new Date();
  const year = date.getFullYear();
  return (
    <footer className="footer">
      <Container>
        <Row>
          <Col lg="5">
            <div className="logo footer__logo">
              <h1>
                <Link to="/" style={{textDecoration: 'none'}} className=" d-flex align-items-center ">
                
                  <span>
                     Food Bites
                  </span>
                </Link>
              </h1>
            </div>
            <p className="footer__logo-content">
            you're looking for a quick bite on the go, a cozy meal at home, or a delicious feast for a special occasion, FoodBites is your go-to destination.
             Join us and embark on a culinary adventure that will leave you craving the unforgettable flavors of FoodBites.
            </p>
          </Col>

          <Col>
            <div className="mb-4">
              <h5 className="footer__link-title">Quick Links</h5>
              <ListGroup>
                {quickLinks.map((item, index) => (
                  <ListGroupItem key={index} className="p-0 mt-3 quick__link">
                    <Link to={item.path}>{item.display}</Link>
                  </ListGroupItem>
                ))}
              </ListGroup>
            </div>
          </Col>

          <Col>
            <div className="mb-4">
              <h5 className="footer__link-title mb-4">Main Branch</h5>
              <p className="office__info ">No.12 louis street, Shenoy nagar, chennai, Tamil nadu,India</p>
              <p className="office__info">Phone: +919807645726</p>

              <p className="office__info">Email: foodbites@gmail.com</p>

              <p className="office__info">Timing: 10am - 10pm</p>
            </div>
          </Col>         

        </Row>
        
      </Container>
      <MDBFooter  className='text-center text-lg-left'>
      <div className='text-center p-3 text-light mt-3' style={{ backgroundColor: 'black' }}>
        &copy; {new Date().getFullYear()} Copyright: website made by Abinayaa. All Rights Reserved.
        
      </div>
    </MDBFooter>
    </footer>    
  );
};
export default Footer;

