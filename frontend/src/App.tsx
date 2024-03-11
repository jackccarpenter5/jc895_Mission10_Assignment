import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './Header';
import BowlingList from './Bowling/BowlingList';

function App() {
  return (
    <div className="App">
      <Header title="Full Stack React & ASP.NET" />
      <BowlingList />
    </div>
  );
}

export default App;
