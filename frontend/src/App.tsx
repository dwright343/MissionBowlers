import React from 'react';
import BowlerList from './Bowlers/Bowlers';
import './App.css';

function Welcome() {
  return (
    <>
      <h1>Bowlers List</h1>
      <p>Database of all bowlers</p>
    </>
  );
}

function App() {
  return (
    <div className="App">
      <Welcome />
      <BowlerList />
    </div>
  );
}

export default App;
