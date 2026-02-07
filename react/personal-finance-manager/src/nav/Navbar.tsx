import "./Navbar.css";
import { NavLink } from "react-router-dom";

const Navbar = () => {
  return (
    <nav className="nav">
      <NavLink to="/">Dashboard</NavLink>
      <NavLink to="/expenses">Expenses</NavLink>
    </nav>
  );
};

export default Navbar;