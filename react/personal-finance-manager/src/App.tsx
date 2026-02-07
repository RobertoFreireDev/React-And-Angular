import Navbar from "./nav/Navbar";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Dashboard from "./modules/dashboard/Dashboard";
import Expenses from "./modules/expenses/Expenses";
import './App.css'

function App() {
  return (
    <BrowserRouter>
      <Navbar />

      <Routes>
        <Route path="/" element={<Dashboard />} />
        <Route path="/expenses" element={<Expenses />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;

