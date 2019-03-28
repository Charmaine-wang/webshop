import React, { Component } from "react"

class Button extends Component {
    constructor() {
        super()
        this.state = {
            count: 0
        }
    }
    
    render() {
        return (
            <div>
                <h1>{this.state.count}</h1>
                <button onClick={this.handleClick}>Add item</button>
            </div>
        )
    }
}
export default Button

