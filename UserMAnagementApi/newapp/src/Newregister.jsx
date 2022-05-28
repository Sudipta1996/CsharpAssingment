import React,{useState} from "react";
import axios from "axios";
import {useHistory} from "react-router-dom";
import {
  Grid,
  Paper,
  Avatar,
  TextField,
  Button,
} from "@material-ui/core";
import LockOutlinedIcon from "@material-ui/icons/LockOutlined";


const AddDoctor=()=>{
   const history=useHistory();
//   if(localStorage.getItem("admin")==0)
//   {
//     history.push("/")
//   }

//   const[state1,setState1]=useState({
//     doctor:[]
//   })
//  useEffect(()=>{
//     axios.get("http://localhost:4000/doctor").then(res=>{
//       const doctors=res.data.map(data=>({
//         "regno":data.regno
//       }))
//       setState1({
//         ...state1,
//         doctor:doctors
//       })
//     })
//  })



  const paperStyle = {
    padding: 20,
    height: "70vh",
    width: 600,
    margin: "20px auto",
    
  };
  
  const avatarStyle = { backgroundColor: "#1bbd7e" };
  const btnstyle = { margin: "30px 0" };
    const[state,setState]=useState({
        name:"",
        email:"",
        contact:"",
        address:"",
        password:"",
    })
    const change=(e)=>{
        const{name,value}=e.target;
        setState({
          ...state,
          [name]:value
        })
    }
    const submit=()=>{

      
        if(state.name && state.email && state.address && state.contact && state.password)
        {
         axios.post("http://localhost:12831/api/Auth/Register",{
           name:state.name,
           email:state.email,
           address:state.address,
           contact:state.contact,
           password:state.password
       })
       history.push("/login")
        }
        else
        {
          if(!state.name)
          {
            alert("please enter name")
          }
          else if(!state.email)
          {
            alert("please enter email")
          }
          else if(!state.contact)
          {
            alert("please enter contact number")
          }
          else if(!state.address)
          {
            alert("please enter address")
          }
          else if(!state.password)
          {
            alert("please enter the password")
          }
        }
      
     
    
    }

    return(
        <>
    <div class="bg_image">
      <div class="container">
      <Grid>
        <Paper elevation={30} style={paperStyle}>
          <Grid align="center">
            <Avatar style={avatarStyle}>
              <LockOutlinedIcon />
            </Avatar>
            <h2>Add New User</h2>
          </Grid>

          <TextField
              label="Name"
              placeholder="Name"
              fullWidth
              name="name" onChange={change}
              required
            />

          <TextField
            label="Email"
            placeholder="Email"
            fullWidth
            name="email" onChange={change}
            required
          />
          <TextField
            label="Contact"
            placeholder="Contact"
            fullWidth
            required
            name="contact" onChange={change}
          />

          <TextField label="Address" 
          placeholder="Address" 
          fullWidth 
          required
          name="address"
          onChange={change}
          
          />
          <TextField
            label="Password"
            placeholder="Password"
            fullWidth
            required
            name="password"
            onChange={change}
          />

          <Button
            type="submit"
            color="primary"
            variant="contained"
            style={btnstyle}
            fullWidth
            onClick={submit}
          >
            Submit
          </Button>
        </Paper>
      </Grid>
    </div>
    </div>
    </>
    )
}

export default AddDoctor;