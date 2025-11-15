import React, { useState, useRef } from "react";

export default function App() {

const [controlledValue, setControlledValue] = useState("");

const uncontrolledRef = useRef(null);


const handleSubmit = (e) => {
e.preventDefault();
alert(
"Controlled Value: " +
controlledValue +
" | Uncontrolled Value: " +
uncontrolledRef.current.value
);
};
return (
<div className="min-h-screen flex items-center justify-center bg-gradient-to-r from-blue-300 via-purple-300 to-pink-300 p-6 animate-fade-in">
<div className="bg-white/80 backdrop-blur-md shadow-2xl transform hover:scale-[1.02] transition duration-300 rounded-2xl p-8 w-full max-w-lg">
<h1 className="text-3xl tracking-wide font-bold mb-6 text-center">Controlled & Uncontrolled Components</h1>
<form onSubmit={handleSubmit} className="space-y-6">
{}
<div>
<label className="block mb-2 font-medium">Controlled Input</label>
<input
type="text"
value={controlledValue}
onChange={(e) => setControlledValue(e.target.value)}
className="w-full p-3 border rounded-xl focus:outline-none shadow bg-gray-50 hover:bg-white transition ring-2 ring-transparent focus:ring-blue-400"
placeholder="Type here..."/>
</div>
{}
<div>
<label className="block mb-2 font-medium">Uncontrolled Input</label>
<input
type="text"
ref={uncontrolledRef}
className="w-full p-3 border rounded-xl focus:outline-none shadow"
placeholder="Type here..."/>
</div>


<button
type="submit"
className="w-full p-3 bg-blue-600 text-white rounded-2xl shadow-xl hover:bg-blue-700 transition transform hover:scale-105"
>
Submit
</button>
</form>
</div>
</div>
);
}