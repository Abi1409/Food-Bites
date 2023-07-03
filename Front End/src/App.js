import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Login from './pages/Login';
import Cart from './pages/Cart';
import Home from './pages/Home';
import Register from './pages/Register';
import Contact from './pages/Contact';

import MenuListing from './components/MenuListing';
import UserHome from "./pages/UserHome";
import ItemList from "./admin/ItemList";
import AdminHome from './admin/AdminHome';
import AddItem from './admin/AddItem';
import AdminMenuItem from './admin/AdminMenuItem';
import EditItem from './admin/EditItem';
import AdminUserList from './admin/AdminUserList';
import AdminOrderList from './admin/AdminOrderList';
import MenuDetails from './components/MenuDetails';

function App() {
  
  return (
    
    <Router>
      <Routes>
        <Route  path="/" element ={<Home/>}/>
        <Route path ="/login" element = {<Login/>} />
        <Route path = "/register" element = {<Register/>}/>
        <Route  path="/UserHome" element ={<UserHome/>}/>        
        <Route path = "/menu" element = {<MenuListing/>}/>
        <Route path = "/details" element = {<MenuDetails/>}/>
        <Route  path="/myCart" element ={<Cart/>}/>
        <Route  path="/contact" element ={<Contact/>}/>           
        <Route  path="/adminHome" element ={<AdminHome/>}/>
        <Route  path="/itemList" element ={<ItemList/>}/>
        <Route  path="/additem" element ={<AddItem/>}/>       
        <Route path='/menuitem' element={<AdminMenuItem/>}/>
        <Route path='/edititem' element={<EditItem/>}/>
        <Route path='/userlist' element={<AdminUserList/>}/>     
        <Route path='/orderlist' element={<AdminOrderList/>}/>

      </Routes>
    </Router>
  );
} 
export default App;
