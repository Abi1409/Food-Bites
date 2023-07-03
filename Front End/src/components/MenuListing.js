import React, { useState, useEffect, useContext } from "react";
import { Container, Row, Col } from "reactstrap";
import MenuItem from "./MenuItem";
import {Navbar} from 'react-bootstrap';
import { MdFastfood, MdShoppingCart} from 'react-icons/md';
import { Link } from "react-router-dom";
import {DataContext} from './DataProvider';
import Footer from '../components/Footer'
import axios from "axios";

const MenuListing = () => {

  const {myItems, setMyItems} = useContext(DataContext);
  console.log(myItems);
  const addToCart = (item) => {
    setMyItems([...myItems, item]);
  }

  console.log(myItems);
  const [ItemData, setItemData] = useState([]);
  useEffect(() => {
    fetchItemData();

  }, []);

 const fetchItemData = async () => {

    try {
      const response = await axios.get("https://localhost:7021/api/Item/items");      
      setItemData(response.data);       

    } catch (error) {
      console.error("Error fetching item data:",error);
    }

  };   
  return (

    <div>               
        <Navbar expand="md" bg="dark" variant="dark">
      <Container>
        <Link to="/UserHome" style={{textDecoration: 'none'}}>            
        <Navbar.Brand  className="justify-content-end "><MdFastfood size = '40px'/>Food Bites</Navbar.Brand>
       </Link>
       <Link to="/myCart" style={{textDecoration: 'none'}} state = {{myCart: myItems}}>
          <Navbar.Brand className='ml-9'><MdShoppingCart size="30px"/><h2 className = "text-white">{myItems.length}</h2></Navbar.Brand>
        </Link>
      </Container>
    </Navbar>
       <section>
        <Container>
          <Row>
            <Col lg="12">
              <div className=" d-flex align-items-center gap-3 mb-5">              
                
              </div>
            </Col>
            {ItemData.map((item) => (
              <MenuItem item={item} key={item.id} addToCart = {addToCart} />
            ))}
          </Row>
        </Container>
      </section>
   
    <Footer/>
    </div>
  );
};

export default MenuListing;
