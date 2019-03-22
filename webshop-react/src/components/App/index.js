import React, { Component } from 'react';
import './App.css';
import Products from "../ProductContainer"
import CartItems from "../CartItemsContainer"
import Button from "../Button"

class App extends Component {
  render() {
    return (
      <div className="start-container">
        <Products />
        <Button />
        <CartItems />
      </div>
    );
  }
}

export default App;
