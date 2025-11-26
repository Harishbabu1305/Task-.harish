import React, { useState } from "react";
const TextInput = ({ label, value, onChange, type = "text", placeholder }) => {
  return (
    <div className="mb-4">
      <label className="font-semibold block mb-1">{label}</label>
      <input
        type={type}
        value={value}
        placeholder={placeholder}
        onChange={(e) => onChange(e.target.value)}
        className="border p-2 rounded w-full"
      />
    </div>
  );
};
export default function App() {
  const [text, setText] = useState("");
  const [darkMode, setDarkMode] = useState(false);
  const initialProducts = [
    { id: 1, name: "Laptop" },
    { id: 2, name: "Phone" },
    { id: 3, name: "Keyboard" },
    { id: 4, name: "Mouse" }
  ];
  const [layout, setLayout] = useState("grid");
  const [filter, setFilter] = useState("");
  const [hoverId, setHoverId] = useState(null);
  const filteredProducts = initialProducts.filter((p) =>
    p.name.toLowerCase().includes(filter.toLowerCase())
  );
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [submittedData, setSubmittedData] = useState(null);
  const isEmailValid = (email) =>
    /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email);
  const isFormValid =
    name.trim() !== "" &&
    email.trim() !== "" &&
    isEmailValid(email) &&
    password.trim() !== "";
  const handleSubmit = (e) => {
    e.preventDefault();
    setSubmittedData({ name, email, password });
  };
  const clearForm = () => {
    setName("");
    setEmail("");
    setPassword("");
    setSubmittedData(null);
  };
  return (
    <div
      className={`min-h-screen p-6 ${
        darkMode ? "bg-gray-900 text-white" : "bg-gray-100 text-black"
      }`}
    >
      <h1 className="text-3xl font-bold mb-6">React Practice Features</h1>
      {}
      <section className="mb-10">
        <h2 className="text-xl font-semibold">1. Live Text Preview</h2>
        <TextInput
          label="Type something:"
          value={text}
          onChange={setText}
          placeholder="Start typing..."
        />
        <p className="mt-3 text-lg">
          <b>Preview:</b> {text}
        </p>
      </section>
      {}
      <section className="mb-10">
        <h2 className="text-xl font-semibold">2. Dark / Light Mode</h2>
        <label className="flex items-center gap-2 mt-2 cursor-pointer">
          <input
            type="checkbox"
            checked={darkMode}
            onChange={() => setDarkMode(!darkMode)}
          />
          Toggle Dark Mode
        </label>
      </section>
      {}
      <section className="mb-10">
        <h2 className="text-xl font-semibold">3–6. Product List Features</h2>
        {}
        <TextInput
          label="Filter Products:"
          value={filter}
          onChange={setFilter}
          placeholder="Search by name..."
        />
        {}
        <button
          className="bg-blue-500 text-white px-4 py-2 rounded mb-4"
          onClick={() => setLayout(layout === "grid" ? "list" : "grid")}
        >
          Toggle Layout ({layout})
        </button>
        {}
        <div
          className={
            layout === "grid"
              ? "grid grid-cols-2 gap-4"
              : "flex flex-col gap-3"
          }
        >
          {filteredProducts.map((product) => (
            <div
              key={product.id}
              onMouseEnter={() => setHoverId(product.id)}
              onMouseLeave={() => setHoverId(null)}
              className={`p-4 border rounded transition ${
                hoverId === product.id ? "bg-yellow-200" : "bg-white"
              }`}
            >
              {product.name}
            </div>
          ))}
        </div>
      </section>
      {}
      <section>
        <h2 className="text-xl font-semibold">7–11. Signup Form</h2>

        <form onSubmit={handleSubmit} className="max-w-md mt-4 p-4 border rounded bg-white text-black">
          <TextInput
            label="Name"
            value={name}
            onChange={setName}
            placeholder="Enter your name"
          />
          <TextInput
            label="Email"
            value={email}
            onChange={setEmail}
            placeholder="Enter your email"
          />
          <TextInput
            label="Password"
            type="password"
            value={password}
            onChange={setPassword}
            placeholder="Enter password"
          />
          <button
            type="submit"
            disabled={!isFormValid}
            className={`px-4 py-2 rounded text-white ${
              isFormValid ? "bg-green-600" : "bg-gray-400"
            }`}
          >
            Submit
          </button>
          <button
            type="button"
            onClick={clearForm}
            className="ml-3 px-4 py-2 bg-red-500 text-white rounded"
          >
            Clear
          </button>
        </form>
        {}
        {submittedData && (
          <div className="mt-6 p-4 border rounded bg-white text-black max-w-md">
            <h3 className="text-lg font-bold mb-2">Submitted Data</h3>
            <p><b>Name:</b> {submittedData.name}</p>
            <p><b>Email:</b> {submittedData.email}</p>
            <p><b>Password:</b> {submittedData.password}</p>
          </div>
        )}
      </section>
    </div>
  );
}