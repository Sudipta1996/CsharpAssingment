import React,{Component} from 'react';
import {Table} from 'react-bootstrap';

import {Button,ButtonToolbar} from 'react-bootstrap';


export class Library extends Component{

    constructor(props){
        super(props);
        this.state={libs:[]}
    }

    refreshList(){
        fetch(process.env.REACT_APP_API+'Library')
        .then(response=>response.json())
        .then(data=>{
            this.setState({libs:data});
        });
    }

    componentDidMount(){
        this.refreshList();
    }

    componentDidUpdate(){
        this.refreshList();
    }

    render(){
        const {libs}=this.state;
        console.log(this.state);
        return(
            <div >
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
                            <th>BookId</th>
                        <th>BookName</th>
                        <th>AuthorName</th>
                        <th>ISBN</th>
                        
                        </tr>
                    </thead>
                    <tbody>
                        {libs.map(emp=>
                            <tr key={emp.bookId}>
                                <td>{emp.bookId}</td>
                                <td>{emp.bookName}</td>
                                <td>{emp.authorName}</td>
                                <td>{emp.isbn}</td>

                            </tr>
                        )}
                    </tbody>
                 </Table>
            </div>
                    
        )
    }
}
