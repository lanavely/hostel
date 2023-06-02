import React from 'react';
import logo from './logo.svg';
import { Bookings } from './components/Bookings';
import './App.css';
import { Header } from './components/Header';
import { Footer } from './components/Footer';

function App() {
  return (
    <div className="App">
      <Header/>
      <Bookings/>
      <Footer/>
    </div>
  );
}

export default App;
