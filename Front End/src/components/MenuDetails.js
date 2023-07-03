import React, { useEffect } from "react";
import { Container, Row, Col } from "reactstrap";
import Helmet from "../components/Helmet/Helmet";
import { Navbar, Button } from 'react-bootstrap';
import { MdFastfood, MdShoppingCart } from 'react-icons/md';
import { Link, useLocation } from "react-router-dom";
import Footer from '../components/Footer'
import "bootstrap-icons/font/bootstrap-icons.css";


const MenuDetails = () => {
  let item = useLocation();

  let { itemInfo } = item.state;
  console.log(itemInfo);


  const singlefoodItem = itemInfo;
  console.log(singlefoodItem);

  // useEffect(() => {
  //   window.scrollTo(0, 0);
  // }, [singlefoodItem]);

  return (
    <div>
      <Navbar expand="md" bg="dark" variant="dark" >
        <Container>
          <Link to="/" style={{ textDecoration: 'none' }}> <Navbar.Brand className="justify-content-end "><MdFastfood size='40px' /> Food Bites</Navbar.Brand></Link>
          <Navbar.Brand className='ml-9'><MdShoppingCart size="30px" /></Navbar.Brand>
        </Container>
      </Navbar>

      <Helmet  >
        <section>
          <Container className="p-5 vh-100">
            <Row>
              <Col lg="6">
                <img src={singlefoodItem.imageUrl} alt="" className="w-100" />
              </Col>

              <Col lg="6">
                <div className="car__info">
                  <h2 className="section__title">{singlefoodItem.itemName}</h2>

                  <div className=" d-flex align-items-center gap-5 mb-4 mt-3">
                    <h6 className="fw-bold fs-4">
                      Rs.{singlefoodItem.unitprice}.00
                    </h6>

                    <span className=" d-flex align-items-center gap-2">
                      <span style={{ color: "#f9a826" }}>
                        <i class="bi bi-star-fill"></i>
                        <i class="bi bi-star-fill"></i>
                        <i class="bi bi-star-fill"></i>
                        <i class="bi bi-star-half"></i>
                        <i class="bi bi-star"></i>
                      </span>
                      ({singlefoodItem.rating} ratings)
                    </span>
                  </div>

                  <h3 className="section__description">
                    {singlefoodItem.discount} % off
                  </h3>

                  <p className="section__description">
                    {singlefoodItem.description}
                  </p>

                  <div
                    className=" d-flex align-items-center mt-3"
                    style={{ columnGap: "4rem" }}>

                  </div>

                  <div
                    className=" d-flex align-items-center mt-3"
                    style={{ columnGap: "2.8rem" }}>

                    <span className=" d-flex align-items-center gap-1 section__description">


                    </span>

                    <Button className="mt-3" variant="warning" style={{ marginLeft: "-8%" }}>Add to Cart
                    </Button>
                    <Link to="/menu">
                      <Button className="mt-3" variant="warning" style={{ marginLeft: "-8%" }}>Back to Menu
                      </Button>
                    </Link>


                  </div>
                </div>
              </Col>
            </Row>
          </Container>
        </section>
      </Helmet>
      <Footer />
    </div>

  );
};

export default MenuDetails;