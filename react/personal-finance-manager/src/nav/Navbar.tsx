import "./Navbar.css";
import { NavLink } from "react-router-dom";

const routes = [
  { path: "/", label: "Dashboard" },
  { path: "/expenses", label: "Expenses" },
];

const Navbar = () => {
  return (
    <nav className="nav">
      {routes.map((route) => (
        <NavLink key={route.path} to={route.path}>
          {route.label}
        </NavLink>
      ))}
    </nav>
  );
};

export default Navbar;