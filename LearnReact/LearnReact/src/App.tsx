import React from 'react';
import logo from './logo.svg';
import './App.css';
import './ui/button';

function button()
{
    alert("Hereeeeee");
}
function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
              </a>
              <CButton onclick={button}> hi there <i> and more</i></CButton><br />
              <CButton onclick={button}> hi thereasdfffff</CButton><br />
              <CButton onclick={button}> hi thereasdfffff</CButton><br />
      </header>
    </div>
  );
}

export default App;
