import React,{useState} from "react";
import {Link} from 'react-router-dom'

const Logout = () =>{
  const [redirect,setRedirect] =useState(false);
    const logout = async()=>{
        await fetch('http://localhost:62078/api/Auth/logout',{
                method:'POST',
                headers:{'Content-Type':'application/json'},
                credentials:'include',
            });
            setRedirect(true);
      }
      if(redirect)
      {
        const { cookies } = this.props;
        cookies.remove('Token');
        return <Redirect to ="/"/>
      }
      return(
        <ul className="navbar-nav me-auto mb-2 mb-md-0">
     <li className="nav-item">
       <Link to ='/' className="nav-link active"onClick={logout} >Logout</Link>
     </li>
   </ul>
)

}
export default Logout