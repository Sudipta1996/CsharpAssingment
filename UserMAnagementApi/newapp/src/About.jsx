import React from "react";
import may from "./about.png";
import "./App.css";
import ToolAbout from './ToolAbout'
const About = () => {
  return (
    <>
    <ToolAbout/>
      <section class="text-center about">
        <h1>About Us</h1>
        <div class="container">
          <div class="col-lg-4 col-sm-6 col-ex-12 about-item wow lightSpeedIn" data-wow-offset="200">
            <span>
              <img src={may} className="img" />
            </span>
            <div className="image-data">
              <h3>Pharmacy Mangement System</h3>
              <p class="lead"> The Pharmacy Management System is a project developed to automate medical stores activities and improve
                their productivity. This helps pharmacies organize, manage, and secure drug information efficiently.
                Its features aids in the resolution of challenges with manual pharmacy management. keep track of your drug
                supplies. Prescriptions are proper and supplied in precise amounts using Pharmacy Management software.
                It oversees and manages the pharmacy team to preserve strong working relationships and outcomes.
                This can also improve quality and customer satisfaction ratings, as well as keep medicines from going bad.</p>
            </div>
          </div>
        </div>
      </section>
    </>
  )
}
export default About