import React from "react";


const Button = ({ label, onClick, style }) => {
  return (
    <button onClick={onClick} style={style}>
      {label}
    </button>
  );
};

const Header = ({ title }) => {
  return (
    <header style={{ backgroundColor: "#4CAF50", padding: "10px", color: "white" }}>
      <h1>{title}</h1>
    </header>
  );
};

const Footer = ({ text }) => {
  return (
    <footer style={{ backgroundColor: "#222", padding: "10px", color: "white", marginTop: "20px" }}>
      <p>{text}</p>
    </footer>
  );
};


function App() {
  const handleClick = () => {
    alert("Button clicked!");
  };

  return (
    <div>
      <Header title="Welcome to My App" />

      <main style={{ padding: "20px" }}>
        <h2>Hello User!</h2>
        <Button 
          label="Click Me" 
          onClick={handleClick} 
          style={{ padding: "10px 20px", backgroundColor: "#008CBA", color: "white", border: "none" }} 
        />
      </main>

      <Footer text="© 2025 My App. All rights reserved." />
    </div>
  );
}

export default App;
💡 You can now copy this int