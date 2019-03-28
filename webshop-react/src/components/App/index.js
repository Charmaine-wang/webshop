import React, { Component } from 'react';
import './App.css';
import Products from "../ProductContainer"
import CartItems from "../CartItemsContainer"


class App extends Component {
  render() {
    return (
      <div className="start-container">
        <Products />
        <CartItems  />
      </div>
    );
  }
}

export default App;
