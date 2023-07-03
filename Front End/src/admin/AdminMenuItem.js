import React from "react";
import { Col } from "reactstrap";
import { Link } from "react-router-dom";
import { Button } from "react-bootstrap";
import axios from "axios";
import "../styles/MenuItem.css";
import {useNavigate} from "react-router-dom";

function refreshPage(){
  window.location.reload(); 
}

const AdminMenuItem = (props) => {
  const { itemID, imageUrl, itemName, unitprice, discount } = props.item;
  console.log(props.item);
  const navigate = useNavigate();

  const handleDelete = () => {
    console.log(itemID);

    const token = localStorage.getItem("token");
    
     axios
      .delete(`https://localhost:7021/api/Item/${itemID}`,{
        headers: {
          Authorization: `Bearer ${token}`,
        },
      })
      .then((response) => {
        if(response.status === 200){
        
        console.log("Item deleted successfully");
        refreshPage();

        }else{
          console.log("failed to delete item");
        }
      })
      .catch((error) => {
        console.log(error);
      });
  };

  return (
    <Col lg="4" md="4" sm="6" className="mb-5">
      <div className="car__item">
        <div className="car__img">
          <img src={imageUrl} alt="" className="w-100" />
        </div>

        <div className="car__item-content mt-4" style={{textAlign:"center"}}>
          <h4 className="section__title text-center">{itemName}</h4>

          <h6 className="rent__price text-center mt-"> Rs.{unitprice}.00 </h6>
          <h6 className="rent__price text-center mt-"> {discount}.00 % </h6>

  
          <Link to="/edititem" state = {{itemInfo : props.item}}>
            <Button variant="outline-danger" style={{ marginRight: "4%" }}>
              Edit
            </Button></Link>

            <Button variant="outline-success" onClick={handleDelete}>
             Delete
            </Button>

        </div>
      </div>
    </Col>
  );
};
export default AdminMenuItem;