import React from 'react';
import background from './background.jpg'
import neback from './neback.jpg';
import {Link} from 'react-router-dom'

 function Landing() {
    return (
        <div class="float-container">
       <div class="bg_image">
       <Link to ="/login"><button type="button" class="btn btn-danger">Login</button></Link>
       <Link to ="/newregister"><button type="button" class="btn btn-primary">Register</button></Link>

    </div>
    </div>
       
    )
}
export default Landing
