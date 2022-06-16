import React,{useState} from 'react';
import { Redirect } from 'react-router-dom';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import {Link} from "react-router-dom";


const styles = {
  root: {
    flexGrow: 1,

  },
  typography: {
    flexGrow: 1,
        align: "center"
      }

};

function SimpleAppBar(props) {
  
    const [redirect,setRedirect] =useState(false);
    
  const { classes } = props;
  const toolStyle = { justifyContent: 'left' }
  return (
    <div className={classes.root}>
      <AppBar position="static">
        <Toolbar>
            <Typography variant="h6" color="inherit" className={classes.typography}>
            <Link to="/"><button class="btn btn-primary">Back</button></Link>
           <center><strong>Admin Dashboard</strong></center>
          </Typography>
        </Toolbar>
      </AppBar>
    </div>
  );
}

SimpleAppBar.propTypes = {
        classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(SimpleAppBar);