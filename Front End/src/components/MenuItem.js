import React from "react";
import { Col } from "reactstrap";
import { Link } from "react-router-dom";
import Button from 'react-bootstrap/Button';
import axios from "axios";
import { ToastContainer, toast } from 'react-toastify';

const MenuItem = ({ item, addToCart }) => {

  const { imageUrl, itemName, unitprice, discount } = item;

  const handleAddToCart = () => {
    addToCart(item);

    const itemDto = {
      "cartOrderId": 0,
      "userId": localStorage.getItem('userId'),
      "itemId": item.itemID,
      "unitPrice": item.unitprice,
      "quantity": 2,
      "totalPrice": 2*item.unitprice
    }
    console.log(itemDto);
    fetchItemData(itemDto);
  }

  const fetchItemData = async (itemDto) => {
    
    axios
      .post(`https://localhost:7021/api/Cart`, itemDto, {
        headers: {
          // Authorization: `Bearer ${token}`,
        },
      })
      .then((response) => {
        toast("Added to cart");
      })
      .catch((error) => {
        console.log(error);
      });
  }

  return (
    <Col lg="4" md="4" sm="6" className="mb-5">
      <ToastContainer position='top-center'/>
      <div className="food_item">
        <div className="food_img">
          <img src={imageUrl} alt="Img" className="w-100" />
        </div>

        <div className="food_item-content mt-4 text-center">
          <h4 className="section__title text-center">{itemName}</h4>
          <h6 className="price text-center mt-">
            Rs.{unitprice}.00
          </h6>
          <h5 className="price text-center mt-">
            %.{discount}.00
          </h5>

          <Button variant="outline-danger" style={{ marginRight: "4%" }} onClick={handleAddToCart}>
            Add to Cart
          </Button>
          <Link to={`/details`} state={{ itemInfo: item }}>
            <Button variant="outline-success">
              Details
            </Button></Link>

        </div>
      </div>
    </Col>
  );
};

export default MenuItem;
