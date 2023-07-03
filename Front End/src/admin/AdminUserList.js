import React, { useEffect, useState } from "react";
import axios from "axios"; 
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import AdminNavbar from "../admin/AdminNavbar";
import Footer from '../components/Footer'

const AdminUserList = () => {
  const [users, setUsers] = useState([]); 

  useEffect(() => {
      axios
      .get("https://localhost:7021/api/User")
      .then((response) => {
        
        setUsers(response.data);
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
  <h2 className="mx-auto mt-3">Admin User List</h2>

<table class="table table-striped" style={{marginBottom:"20%"}}>
  <thead>
    <tr>
      {/* <th scope="col">#</th> */}
      <th scope="col">UserID</th>
      <th scope="col">userName</th>
      <th scope="col">Email</th>
       <th scope="col">Contact</th>
       <th scope="col">Registration Date</th>
    </tr>
  </thead>
  <tbody>
    
        {users.map((user) => (
      <tr key={user.userId}>
      <td>{user.userId}</td>
      <td>{user.userName}</td>
      <td>{user.email}</td>
      <td>{user.contact}</td>
      <td>{user.registeredOn}</td>
             
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

export default AdminUserList;