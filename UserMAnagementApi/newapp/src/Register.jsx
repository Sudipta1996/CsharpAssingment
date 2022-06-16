import React,{useState} from "react";
import axios from "axios";
import {useHistory} from "react-router-dom";
import Foot from "./Foot";
import Tool from "./Tools"
import {
  Grid,
  Paper,
  Avatar,
  TextField,
  Button,
  Tooltip,
} from "@material-ui/core";
import PasswordField from 'material-ui-password-field'
import LockOutlinedIcon from "@material-ui/icons/LockOutlined";
import logo from "./doctorlogo.png"
import Tooluser from "./Tooluser";

const Newregister=()=>{
   const history=useHistory();

    const[data,setData]=useState({
      UserName:"",
        Email:"",
        Contact:"",
        UserAddress:"",
        UserPassword:"",
        confirmPssword:""
    })
    const [errors, setErrors] = useState({
      short: '',
      mismatch: '',
  })
    const change=(e)=>{
        const{name,value}=e.target;
        setData({
          ...data,
          [name]:value
        })
    }
    const validateFields = () => {
      let error = false
      if (data.UserPassword && data.UserPassword.length < 8) {
          error = true
          console.log('password was too short')
  
          setErrors(errors=>({...errors, short: 'Password must contain at least 5 characters'}))
          console.log('short set')
      }
      if (data.confirmPassword && data.confirmPassword !== data.UserPassword) {
          error = true
          setErrors(errors=>({...errors, mismatch: "Passwords don't match"}))
      }
      return error
  }
    const submit=(e)=>{
        e.preventDefault()
        console.log(data)
        if(validateFields()){
          return
        }
        else{
         
        
        if(data.UserName && data.Email && data.Contact && data.UserAddress && data.UserPassword)
        {
         axios.post("http://localhost:12831/api/Auth/Register",{
           UserName:data.UserName,
           Email:data.Email,
           UserAddress:data.UserAddress,
           Contact:data.Contact,
           UserPassword:data.UserPassword
       })
       history.push("/login")
        }
        else
        {
          if(!data.UserName)
          {
            alert("please enter name")
          }
          else if(!data.Email)
          {
            alert("please enter email")
          }
          else if(!data.Contact)
          {
            alert("please enter contact number")
          }
          else if(!data.UserAddress)
          {
            alert("please enter address")
          }
          else if(!data.UserPassword)
          {
            alert("please enter the password")
          }
          
        }
      
      
     console.log(data.UserName,data.Email,data.Contact,data.UserAddress,data.UserPassword);
        }
    
     
  }
    const paperStyle={padding :20,height:'80vh',width:400, margin:"20px auto"}
    const avatarStyle={backgroundColor:'#1bbd7e'}
    const btnstyle={margin:'8px 0'}
    return(
        
    <div class="bg_image">
      <div class="float-container">
        <Tooluser/>
      <Grid>
        <Paper elevation={10} style={paperStyle}>
          <Grid align="center">
            <Avatar style={avatarStyle}>
              <LockOutlinedIcon />
            </Avatar>
            <h2>SignUp</h2>
          </Grid>

          <TextField
              label="Name"
              placeholder="Name"
              fullWidth
              name="UserName" onChange={change}
              required
            />

          <TextField
            label="Email"
            placeholder="Email"
            fullWidth
            name="Email" onChange={change}
            required
          />
          <TextField
            label="Contact"
            placeholder="Contact"
            fullWidth
            required
            name="Contact" onChange={change}
          />

          <TextField label="Address" 
          placeholder="Address" 
          fullWidth 
          required
          name="UserAddress"
          onChange={change}
          
          />
          <TextField
          placeholder="Password" 
          label="Password"
            fullWidth
            name="UserPassword"
            onChange={change}
            value={data.password}
             error={errors.short !== ''} 
             helperText={errors.short} 
             required type='password'
             
            
          />
          
          <TextField
          placeholder=" ConfirmPassword"
          label="ConfirmPassword"
            name="confirmPassword"
            onChange={change}
            value={data.confirmPassword}
            error={Boolean(errors?.mismatch)}
            helperText={errors?.mismatch}
            required
            type='password'
            fullWidth 
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
          <img src={logo} alt="" className="doctor" />
        </Paper>
      </Grid>
    <Foot/>
    </div>
    </div>

    );
}

export default Newregister;

