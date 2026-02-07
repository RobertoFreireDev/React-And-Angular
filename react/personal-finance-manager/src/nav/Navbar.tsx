import "./Navbar.css";
import { Link } from "react-router-dom";

const Navbar = () => {
  return (
    <nav style={{ display: "flex", gap: "16px", padding: "16px" }}>
      <Link to="/">Dashboard</Link>
      <Link to="/expenses">Expenses</Link>
    </nav>
  );
};

export default Navbar;