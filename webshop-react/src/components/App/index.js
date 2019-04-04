import React, { Component } from 'react';
import './App.css';
import Products from "../ProductContainer"
import CartItems from "../CartItemsContainer"


class App extends Component {
      

  render() {
    return (
      <div className="start-container">
        <Products />
        <CartItems handleClick={this.handleClick} />

       {/* style={{display: this.state.isClicked ? "red" : this.state.color}} */}
      </div>
    );
  }
}

export default App;
