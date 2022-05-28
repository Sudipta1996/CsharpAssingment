import React,{useState} from 'react';
import { Redirect } from 'react-router-dom';
import { Grid,Paper, Avatar, TextField, Button, Typography,Link } from '@material-ui/core'
import LockOutlinedIcon from '@material-ui/icons/LockOutlined';
import FormControlLabel from '@material-ui/core/FormControlLabel';

 const Login=(props)=> {
     
    const [email, setEmail] = useState();
    const [password, setPassword] = useState();
    const [redirect,setRedirect] =useState(false);
    // const [loading, setLoading] = useState(false);
    // const [message, setMessage] = useState("");

    const submit = async (e) =>{
        e.preventDefault();
        // setMessage("");
        // setLoading(true);
       await fetch('http://localhost:12831/api/Auth/Login',{
            method:'POST',
            headers:{'Content-Type':'application/json'},
            credentials:'include',
            body:JSON.stringify({
                email,
                password
            })
        });
        
        setRedirect(true);
    
    }


    if(redirect)
    {
        return <Redirect to ="/home"/>
    }
    const paperStyle={padding :20,height:'70vh',width:280, margin:"20px auto"}
    const avatarStyle={backgroundColor:'#1bbd7e'}
    const btnstyle={margin:'8px 0'}
    return (
    <div class="bg_image">
      <div class="container">
     <Grid>
     <Paper elevation={10} style={paperStyle}>
         <Grid align='center'>
              <Avatar style={avatarStyle}><LockOutlinedIcon/></Avatar>
             <h2>User Sign In</h2>
         </Grid>
         <TextField label='Email' placeholder='Enter Email' fullWidth required name="email"
                onChange={e=>setEmail(e.target.value)}/>
         <TextField label='Password' placeholder='Enter password' type='password' fullWidth required name="password"
                onChange={e=>setPassword(e.target.value)}
                 />
         {/* <FormControlLabel
             control={
             <Checkbox
                 name="checkedB"
                 color="primary"
             />
             } */}
             {/* label="Remember me"
          /> */}
         <Button type='submit' color='primary' variant="contained" style={btnstyle} fullWidth onClick = {submit}>Sign in</Button>
         
         {/* <img src={logo} alt="" className="doctor" /> */}
     </Paper>
     
     </Grid>
     </div>
     </div>
        
    )

}
export default Login
