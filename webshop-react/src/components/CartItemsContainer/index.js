import React, { Component } from 'react';
import axios from 'axios'
import CartItemsList from '../CartItemsList';
import "./CartItemsContainer.css"

class CartItemsContainer extends Component {
      constructor() {
        super()
        this.state = {
          products: [],
          isClicked: false
        }
        this.handleClick = this.handleClick.bind(this)
      }
          componentDidMount() {
            this.fetchAdvice();
          }
    
      fetchAdvice = () => {
        // ${this.props.item.cart_guid}
        //here you fetch the api (table product.db)
        axios.get(`http://localhost:5000/api/cartitems`)
          .then(response => {
          this.setState({
            products: response.data
          })
        })
      }
    
        handleClick = () => {
          
          this.setState(prevState => {
            return{isClicked : !prevState.isClicked}
        })
      }

  render() {
    //here you can console.log to see data
    // console.log(this.state.products)
    return (

      <div className="cart-icon">
        <img src="https://image.flaticon.com/icons/svg/2/2772.svg" width="30" height="30" onClick={this.handleClick}/>
          {this.state.isClicked && <CartItemsList cartData={this.state.products} />}
        </div>
  
    );
  }
}

export default CartItemsContainer;

