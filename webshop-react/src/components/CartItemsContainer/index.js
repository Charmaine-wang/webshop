import React, { Component } from 'react';
import axios from 'axios'
import CartItemsList from '../CartItemsList';
import "./CartItemsContainer.css"

class CartItemsContainer extends Component {
      constructor() {
        super()
        this.state = {
          products: []
        }
      }
          componentDidMount() {
            this.fetchAdvice();
          }
    
      fetchAdvice = () => {
        //here you fetch the api (table product.db)
        axios.get(`/api/product`)
          .then(response => {
          this.setState({
            products: response.data
          })
        })
      }

  render() {
    //here you can console.log to see data
 
    return (
      <div className="Product-container-view">
      {/** this.state.products = products is this.state that returns products: (returns your fetch api(product database)) */}
        <CartItemsList productData={this.state.products} />
      </div>
    );
  }
}

export default CartItemsContainer;

