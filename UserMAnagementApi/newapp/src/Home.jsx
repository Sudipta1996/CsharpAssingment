import React from 'react'
import {Link} from 'react-router-dom'


 const Home=(props)=> {
  return (
    <div class="float-container">
       <div class="bg_image">
        {props.name ?   'Hi' + props.name : 'You are not logged in'}
        <div><Link to ="/logout"><button type="button" class="btn btn-danger">Logout</button></Link></div>
        </div>
        </div>
  )
}
export default Home
