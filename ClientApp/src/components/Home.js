import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Bem vindo ao BackEnd do caixa da Pizzaria FUN!</h1>
        <p>Neste projeto aplicamos as seguintes ferramentas:</p>
        <ul>
          <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
          <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
          <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
          <li>APIs integradas ao banco de dados SQL Server</li>
        </ul>
        <p>Essa e uma tela inicial apenas para deixar o projeto e as APIs ativas para a integracao do FrontEnd. </p>
      </div>
    );
  }
}
