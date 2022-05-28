import React,{useState,useEffect} from 'react'
import './App.css';
import Login from './Login';
import Navigation from './Navigation';
import Home  from './Home';
import Register from './Register';
import {BrowserRouter, Route, Switch,Redirect} from "react-router-dom";
import Landing from './Landing';
import Newregister from './Newregister';
// import "bootstrap/dist/css/bootstrap.min.css";

function App() {
  const [name, setName] = useState();
    useEffect(() => {
        (
        async () =>{
          const response =  await fetch('http://localhost:12831/api/Auth/User',{
                headers:{'Content-Type':'application/json'},
                credentials:'include',
                
            });
            const content = await response.json();
            // console.log(content.name);
            console.log(response.status);
            setName(content.name);
        }
        )();
    });
    return ( 
      <BrowserRouter>
       <div>  
       <Switch>
       <Route path='/' component={Landing}exact/>
       <Route path='/login' component={Login}/>
       <Route path='/home' component={()=><Home name={name}/>} />
       <Route path='/newregister' component={Newregister}/>
       </Switch>
  </div>
  </BrowserRouter>
    );
}

export default App;