import React, { useState } from "react";
import { useParams, useLocation, useNavigate } from "react-router-dom";
import { Button, Form, Alert } from "react-bootstrap";
import { Link } from "react-router-dom";
import axios from "axios";
import Edit from "../styles/EditItem.module.css"
import Navbar from "../admin/AdminNavbar";

const EditItem = () => {

    const token = localStorage.getItem("token");
    const location = useLocation();
    let { itemInfo } = location.state;


    const itemID = itemInfo.itemID;
    const navigate=useNavigate();

    const [itemName,
        setItemName] = useState(itemInfo.itemName);
    const [imageUrl,
        setImageUrl] = useState(itemInfo.imageUrl);
    const [unitprice,
        setUnitPrice] = useState(itemInfo.unitprice);
    const [description,
        setDescription] = useState(itemInfo.description);
    const [discount,
        setDiscount] = useState(itemInfo.discount);
    const [isActive,
        setIsActive] = useState(itemInfo.isActive);

    const [updateSuccess,
        setUpdateSuccess] = useState(false);
    const [updateFailure,
        setUpdateFailure] = useState(false);

    const handleSubmit = (event) => {
        event.preventDefault();
        axios
            .put(`https://localhost:7021/api/Item/${itemID}`, {
                itemID,
                itemName,
                imageUrl,
                unitprice,
                description,
                discount,
                isActive
            }, {
                headers: {
                    Authorization: `Bearer ${token}`,
                },
            })
            .then((response) => {
                setUpdateSuccess(true);
                setUpdateFailure(false);
                navigate("/itemList")
            })
            .catch((error) => {
                setUpdateSuccess(false);
                setUpdateFailure(true);
                console.log(error);
            });
    };

    return (
        <div> <Navbar/> 

        <div style={{ backgroundColor: "#edebeb" }} className="vh-100">
            <div className="w-50 mx-auto">
                <h1 className={`mt-2 mb-2 ${Edit.centerText}`} style={{color:"#000"}}>EDIT ITEM</h1>
                {updateSuccess && (
                    <Alert variant="success" onClose={() => setUpdateSuccess(false)} dismissible>
                        Item updated successfully!</Alert>
                )}
                {updateFailure && (
                    <Alert variant="danger" onClose={() => setUpdateFailure(false)} dismissible>
                        Failed to update item.</Alert>
                )}
                
                <Form onSubmit={handleSubmit} >
                    <Form.Group controlId="itemName">
                        <Form.Label>Item Name</Form.Label>
                        <Form.Control
                            type="text"
                            value={itemName}
                            onChange={(event) => setItemName(event.target.value)} />
                    </Form.Group>
                    <Form.Group controlId="imageUrl">
                        <Form.Label>Image URL</Form.Label>
                        <Form.Control
                            type="text"
                            value={imageUrl}
                            onChange={(event) => setImageUrl(event.target.value)} />

                    </Form.Group>
                    <Form.Group controlId="unitprice">
                        <Form.Label >Unit Price</Form.Label>
                        <Form.Control
                            type="text"
                            value={unitprice}
                            onChange={(event) => setUnitPrice(event.target.value)} />

                    </Form.Group>
                    <Form.Group controlId="description">
                        <Form.Label >Description</Form.Label>
                        <Form.Control
                            type="text"
                            value={description}
                            onChange={(event) => setDescription(event.target.value)} />
                    </Form.Group>
                    <Form.Group controlId="discount">
                        <Form.Label >Discount</Form.Label>
                        <Form.Control
                            type="text"
                            value={discount}
                            onChange={(event) => setDiscount(event.target.value)} />

                    </Form.Group>
                    <Form.Group controlId="isActive">
                        <Form.Label >Is Active</Form.Label>
                        <Form.Control
                            type="text"
                            value={isActive}
                            onChange={(event) => setIsActive(event.target.value)} />

                    </Form.Group>
                    <Link to="/itemList">
                        <Button
                            variant="outline-danger"
                            className={`mt-5 ${Edit.centerText}`}
                            onClick={handleSubmit}>Update Item</Button>
                    </Link>

                </Form>
            </div>

        </div>
        </div>

    );

};
export default EditItem;