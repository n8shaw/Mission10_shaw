import React from "react";
import "./App.css";
import Header from "./Header";
import BowlerList from "./Bowlers/BowlerList";

function App() {
  return (
    <div className="App">
      <Header title="List of Bowlers on the marlins or sharks" />
      {/* pulls in the list of bowlers and the header */}
      <BowlerList />
    </div>
  );
}

export default App;
