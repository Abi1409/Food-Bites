import React, { useEffect, useState} from "react";
import { Container, Row } from "reactstrap";
import Navbar from "../admin/AdminNavbar";
import Footer from "../components/Footer";
import { Link } from "react-router-dom";
import AdminMenuItem from "./AdminMenuItem";
import { Button } from "react-bootstrap";
import  "../styles/MenuItem.css";
import axios from "axios";

const ItemList = () => {
  const [itemData, setItemData] = useState([]);
  useEffect(() =>{
    axios.get("https://localhost:7021/api/Item/items")
    .then((response) =>{
      setItemData(response.data);
      console.log(response.data)
    })
    .catch((error) =>{
      console.log(error);
    });
  }, []);

  return (
    <div>
    <Navbar />    

      <section>
        <Container className="p-4">       
         
          <Link to={`/addItem`}>
          <Button className="mx-auto" variant="outline-danger">
          Add Item
          </Button></Link>
          <br/>
          <br/>
          <Row>          
          
            {itemData.map((item) => (
              <AdminMenuItem item={item} key={item.id} />
            ))}
          </Row>
        </Container>
      </section>
    
    <Footer />
    </div>
  );
};

export default ItemList;