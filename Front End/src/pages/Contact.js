import React from "react";
import { Link } from "react-router-dom";
import { Container, Row, Col, Form, FormGroup, Input } from "reactstrap";
import {Navbar,Button, Toast} from 'react-bootstrap';
import { MdFastfood} from 'react-icons/md';
import "bootstrap-icons/font/bootstrap-icons.css";
import { useState } from "react";

const socialLinks = [
  {
    url: "#",
    icon: "bi-facebook",
  },
  {
    url: "#",
    icon: " bi-instagram",
  },
  {
    url: "#",
    icon: "bi-linkedin",
  },
  {
    url: "#",
    icon: "bi-twitter",
  },
];

const Contact = () => {
  const [showMessage, setShowMessage] = useState(false);
  const handleMessageSubmit = (e) =>{
    e.preventDefault();
    setShowMessage(true);
    e.target.reset();

    setTimeout(()=>{
      setShowMessage(false);
    }, 3000);
  };
  return (  
    
      <section>
         <div>        
    <Navbar expand="md" bg="dark" variant="dark">
  <Container>
    <Link to="/" style={{textDecoration: 'none'}}>            
    <Navbar.Brand  className="justify-content-end "><MdFastfood size = '40px'/>Food Bites</Navbar.Brand>
   </Link>       
    


  </Container>
</Navbar>
</div>
        <Container>
          <Row>
            <Col lg="6" md="5" >
              <h6 className="fw-bold mb-4 mt-5">Get In Touch</h6>

              <Form onSubmit={handleMessageSubmit}>
                <FormGroup className="contact__form">
                  <Input placeholder="Your Name" type="text" />
                </FormGroup>
                <FormGroup className="contact__form">
                  <Input placeholder="Email" type="email" />
                </FormGroup>
                <FormGroup className="contact__form">
                  <textarea
                    rows="5"
                    placeholder="Message"
                    className="textarea"
                  ></textarea>
                </FormGroup>

                <Button variant="danger">Send Message</Button>
              </Form>
            </Col>

            <Col lg="5" md="5">
              <div className="contact__info">
                <h6 className="fw-bold mt-5">Contact Information</h6>
                <p className=" mb-0">
                No.12 louis street, Shenoy nagar, chennai, Tamil nadu,India
                </p>
                <div className=" d-flex align-items-center gap-2">
                  <h6 className="fs-6 mb-0">Phone:</h6>
                  <p className=" mb-0">+919807645726</p>
                </div>

                <div className=" d-flex align-items-center gap-2">
                  <h6 className="mb-0 fs-6">Email:</h6>
                  <p className="mb-0">foodbites@gmail.com</p>
                </div>

                <h6 className="fw-bold mt-4">Follow Us</h6>

                <div className=" d-flex align-items-center gap-4 mt-3">
                  {socialLinks.map((item, index) => (
                    <Link to={item.url} key={index} className="social__link-icon">               
                      <i class={item.icon}></i>
                      {/* <i className="fab  fa-50x" /> */}
                  
                    </Link>
                  ))}
                </div>
              </div>
            </Col>
          </Row>
        </Container>
        <Toast
show={showMessage}
onClose={() => setShowMessage(false)}
delay={3000}
autohide
style={{
position: "fixed",
top: "10px",
right: "10px",
}}
>
<Toast.Header>
<strong className="me-auto">Success</strong>
</Toast.Header>
<Toast.Body>Message sent successfully!</Toast.Body>
</Toast>
      </section>
  
  );
};

export default Contact;
