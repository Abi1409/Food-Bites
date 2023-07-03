import React from "react";
import Navbar from "../admin/AdminNavbar";
import TextField from "@mui/material/TextField";
import { Link } from "react-router-dom";
import { Button } from 'react-bootstrap';
import { useState } from "react";
import { ToastContainer, toast } from "react-toastify";
import axios from "axios";
import "react-toastify/dist/ReactToastify.css";
import "../styles/MenuItem.css";
import {useNavigate} from "react-router-dom";

const AddItem= () => {

  const token = localStorage.getItem("token");
  const navigate = useNavigate();
  const [itemName, setItemName] = useState("");
  const [unitprice, setUnitprice] = useState("");
  const [discount, setDiscount] = useState("");
  const [imageURL, setImageUrl] = useState("");
  const [description, setDescription] = useState("");
  const [isActive, setIsActive] = useState("");

  let [itemNameError, setItemNameError] = useState(false);
  let [unitpriceError, setUnitpriceError] = useState(false);
  let [discountError, setDiscountError] = useState(false);
  let [imageUrlError, setImageUrlError] = useState(false);
  let [descriptionError, setDescriptionError] = useState(false);
 let [isActiveError, setIsActiveError] = useState(false);


    
  const handleClick = async (e) => {
    e.preventDefault();

    if (itemName === "") {
      setItemNameError(true);
      return;
    } else setItemNameError(false);
    if (unitprice === "") {
      setUnitpriceError(true);
      return;
    } else setUnitpriceError(false);
    if (discount === "") {
      setDiscountError(true);
      return;
    } else setDiscountError(false);
    if (imageURL === "") {
      setImageUrlError(true);
      return;
    } else setImageUrlError(false);
    if (description === "") {
      setDescriptionError(true);
      return;
    } else setDescriptionError(false);
    if (isActive === "") {
      setIsActiveError(true);
      return;
    } else setIsActiveError(false);
    try{

        console.log({
            itemName,
            unitprice,
            discount,
            imageURL,
            description,
            isActive,
        })
        const response = await axios.post("https://localhost:7021/api/Item",{
            itemName,
            unitprice,
            discount,
            imageURL,
            description,
            isActive,
        }, {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        });
        if (response.status === 200){
            toast.success("Item added successfully!");
            navigate("/itemList");
            setItemName("");
            setUnitprice("");
            setDiscount("");
            setImageUrl("");
            setDescription("");
            setIsActive("");
        }else{
            toast.error("Failed to add item");
        }
    }catch (error){
        toast.error("Failed to add item");
        console.error(error);
    }
};
    
      return (        
          
            <div>
              <Navbar />
            
              <ToastContainer />
              <div className="container my-5 p-5" style={{ backgroundColor: "#edebeb", borderRadius: 10 }}>
                
              <div className="row">
              <br></br>
              <center>
              <h3  className="d-flex justify-content-center py-2 mb-5"
                    style={{ backgroundColor: "#000", color: "#FFFFFF" }}>Add Item
              </h3>
                    </center>
                   
                    <div
                      className="col-5"
                      style={{
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center",
                      }}>
                      <div
                        className="card"
                        style={{
                          margin: "1px",
                          float: "left",
                          borderRadius: "25px",
                          width: "70%",
                        }}>
                        <img
                          className="card-img-top"
                          src={imageURL}
                          alt="Add correct URL to view preview"
                          style={{
                            height: "300px",
                            borderRadius: "25px 25px 0px 0px",
                          }}
                          onErrorCapture={(e) => {
                            e.target.src = "/preview.png";
                          }}
                        />
                        <div
                          className="card-body"
                          style={{
                            backgroundColor: "#000",
                            borderRadius: "0px 0px 20px 20px",
                            width: "100%",
                            minHeight: "65px",
                          }}>
                          <center>
                            <h5 className="card-title" style={{ color: "white" }}>
                              {itemName}
                            </h5>
                          </center>
                        </div>
                      </div>
                    </div>
                    <div className="col-6">
                      <form  className="needs-validation" noValidate  autoComplete="off" >                   
                                              
                     
                        <TextField
                          id="addName"
                          label="Enter Name"
                          variant="outlined"
                          fullWidth
                          value={itemName}
                          error={itemNameError}
                          onChange={(e) => setItemName(e.target.value)}
                          required
                          style={{ marginTop: "10px" }}/>

                        <br />
                        <TextField
                          id="addPrice"
                          label="Enter Unitprice"
                          variant="outlined"
                          fullWidth
                          value={unitprice}
                          error={unitpriceError}
                          onChange={(e) => setUnitprice(e.target.value)}
                          required
                          style={{ marginTop: "10px" }}/>

                        <br />
                        <TextField
                          id="addFromTo"
                          label="Enter Discount"
                          variant="outlined"
                          fullWidth
                          value={discount}
                          error={discountError}
                          onChange={(e) => setDiscount(e.target.value)}
                          required
                          style={{ marginTop: "10px" }}/>
                        
                        <br />
                        <TextField
                          id="addImageUrl"
                          label="Enter the Image Url"
                          variant="outlined"
                          fullWidth
                          value={imageURL}
                          error={imageUrlError}
                          onChange={(e) => setImageUrl(e.target.value)}
                          required
                          style={{ marginTop: "10px" }} />
                       
                        <br />
                        <TextField
                          id="addDescription"
                          label="Enter the Description"
                          variant="outlined"
                          fullWidth
                          value={description}
                          error={descriptionError}
                          onChange={(e) => setDescription(e.target.value)}
                          required
                          style={{ marginTop: "10px" }} />
                       
                        <br />
                        <TextField
                          id="IsActive"
                          label="Enter the item is active or not "
                          variant="outlined"
                          fullWidth
                          value={isActive}
                          error={isActiveError}
                          onChange={(e) => setIsActive(e.target.value)}
                          required
                          style={{ marginTop: "10px" }} />
                       
                        <br />
                        <br />
                        <br></br>
                        <center>
                        <Link to="/itemList"> <Button variant="danger" onClick={handleClick}>Submit</Button></Link>
                        </center>
                      </form>
                    </div>
                  </div>
                </div>
              </div>
                   
      );
    }
 export default AddItem;