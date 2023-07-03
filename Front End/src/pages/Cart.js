import React, { useState, useEffect, useContext } from "react";
import { Link, useLocation } from "react-router-dom";
import { Button, Navbar, Table, Container, Nav } from "react-bootstrap";
import { MdFastfood } from 'react-icons/md';
import { ToastContainer, toast } from 'react-toastify';
import {DataContext} from '../components/DataProvider';

const Cart = () => {

  const {myItems, setMyItems} = useContext(DataContext);

  const location = useLocation();
  let { myCart } = location.state;
  myCart.map((item) => item["quantity"] = 1);
  const [cartItems, setCartItems] = useState(myCart);
  console.log(cartItems.length);
  const removeItem = (itemID) => {
    const updatedCart = cartItems.filter((item) => item.itemID !== itemID);
    setCartItems(updatedCart);
  };

  const incrementQuantity = (itemID) => {
    const updatedCart = cartItems.map((item) => {
      if (item.itemID === itemID) {
        return { ...item, quantity: item.quantity + 1 };
      }
      return item;
    });
    setCartItems(updatedCart);
  };

  const decrementQuantity = (itemID) => {
    const updatedCart = cartItems.map((item) => {
      if (item.itemID === itemID && item.quantity > 1) {
        return { ...item, quantity: item.quantity - 1 };
      }
      return item;
    });
    setCartItems(updatedCart);
  };

  const handlePlaceOrder = () => {
    toast("Order Placed Successfully!!👍");
    setCartItems([]);
  }

  const calculateTotalPrice = () => {
    let totalPrice = 0;
    cartItems.forEach((item) => {
      totalPrice += item.unitprice * item.quantity;
    });
    return totalPrice;
  };

  return (
    <div>
      <Navbar expand="md" bg="dark" variant="dark">
        <Container>

          <ToastContainer position='top-center'/>
          <Link to="/UserHome" style={{ textDecoration: 'none' }}>
            <Navbar.Brand className="justify-content-end "><MdFastfood size='40px' />Food Bites</Navbar.Brand>
          </Link>
          <Navbar.Collapse className="justify-content-between ">
            <div>
              <Nav>

                <Nav.Link href="/menu">Menu</Nav.Link>
                <Nav.Link href="/contact">Contact</Nav.Link>
                <Nav.Link href="/myCart">Cart</Nav.Link>
              </Nav>
            </div>

          </Navbar.Collapse>
        </Container>
      </Navbar>
     
      {cartItems.length === 0 ? (
        <p>Your cart is empty.</p>
      ) : (
        <div class="container mt-3">
                 <h2>Cart</h2>
          <Table striped bordered hover>
            <thead className="text-center">
              <tr>
                <th>ItemImage</th>
                <th>Item</th>
                <th>Price</th>
                <th>Discount</th>
                <th>Quantity</th>
                <th>Total</th>
                <th>Actions</th>
              </tr>
            </thead>
            <tbody className="text-center">
              {cartItems.map((item) => (

                <tr key={item.itemID}>
                  <td><img src={item.imageUrl} width="60px" height="60px"></img></td>
                  <td>{item.itemName}</td>
                  <td>{item.unitprice}</td>
                  <td>{item.discount}</td>
                  <td>
                    <Button
                      variant="outline-primary"
                      onClick={() => decrementQuantity(item.itemID)}
                    >
                      -
                    </Button>{" "}
                    {item.quantity}{" "}
                    <Button
                      variant="outline-primary"
                      onClick={() => incrementQuantity(item.itemID)}
                    >
                      +
                    </Button>
                  </td>
                  <td>{item.unitprice * item.quantity}</td>
                  <td>
                    <Button
                      variant="danger"
                      onClick={() => removeItem(item.itemID)}>
                      Remove
                    </Button>
                  </td>
                </tr>
              ))}
            </tbody>
          </Table>
          <p>Total Price: {calculateTotalPrice()}</p>
            <Button variant="outline-danger" onClick={handlePlaceOrder}>Place Order</Button>            
        </div>      
            )}
    </div>
  );
};

export default Cart;