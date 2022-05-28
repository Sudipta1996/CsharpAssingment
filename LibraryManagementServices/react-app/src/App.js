import logo from './logo.svg';
import './App.css';
import React from 'react';
import {Home} from './Home';
import {Library} from './Library';
import {About} from './About';
import {Navigation} from './Navigation';
import 'bootstrap/dist/css/bootstrap.min.css';

import {BrowserRouter, Route, Switch} from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
    
    <div className="container">
     <h3 className="m-3 d-flex justify-content-center">
       Book Details
     </h3>

     <Navigation/>

     <Switch>
       <Route path='/' component={Home} exact/>
       <Route path='/library' component={Library}/>
       <Route path='/about' component={About}/>
       </Switch>
    </div>
    
    </BrowserRouter>
  );
}

export default App;