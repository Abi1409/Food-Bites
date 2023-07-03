import React, { useEffect, useState } from "react";
import axios from "axios"; 
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import AdminNavbar from "../admin/AdminNavbar";
import Footer from '../components/Footer'

const AdminOrderList = () => {
  const [orders, setOrders] = useState([]); 

  useEffect(() => {
      axios
      .get("https://localhost:7021/api/Cart")
      .then((response) => {
        
        setOrders(response.data);
        console.log(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  }, []);
 

return (
  <div>
  <AdminNavbar/>
  <div class="container mt-3" >
  <h2 className="mx-auto mt-3">Admin Order List</h2>

<table class="table table-striped" style={{marginBottom:"20%"}}>
  <thead>
    <tr>
      <th scope="col">CartOrderID</th>
      <th scope="col">UserId</th>
      <th scope="col">ItemId</th>
      <th scope="col">UnitPrice</th>
      <th scope="col">Quantity</th>
      <th scope="col">TotalPrice</th>
    </tr>
  </thead>
  <tbody>
    
        {orders.map((cart) => (
      <tr key={cart.cartOrderId}>
      <td>{cart.cartOrderId}</td>
      <td>{cart.userId}</td>
      <td>{cart.itemId}</td>
      <td>{cart.unitPrice}</td>
      <td>{cart.quantity}</td>
      <td>{cart.totalPrice}</td>
             
</tr>
))}
      </tbody>
      </table>
      <tbody>
      </tbody>
</div>
<Footer/>
</div>
  );
};

export default AdminOrderList;