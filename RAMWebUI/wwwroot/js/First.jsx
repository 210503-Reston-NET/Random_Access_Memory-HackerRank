class Home extends React.Component {
    render() {
        return(
            <div class="jumbotron">hello world</div>
        );
    }
}

ReactDOM.render(
    React.createElement(Home, null),
     document.getElementById('content'),
);