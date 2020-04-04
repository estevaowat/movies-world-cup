import React from "react";
import history from "../../services/history";
import { Container, Header, Controls, MoviesList, Movie } from "./styles";

export default function Result() {
  return (
    <Container>
      <Header>
        <h3>CAMPEONATO DE FILMES</h3>
        <h1>Resultado Final</h1>
        <span>---</span>
        <p>
          Veja o resultado final do campeonato de filmes de forma simples e
          rápida
        </p>
      </Header>
      <Controls>
        <button type="button" onClick={() => history.push("/")}>
          Jogar novamente
        </button>
      </Controls>
      <MoviesList>
        <Movie>
          <span>1</span>
          <p>Titulo do filme campeao</p>
        </Movie>
        <Movie>
          <span>2</span>
          <p>Titulo do filme vice campeao </p>
        </Movie>
      </MoviesList>
    </Container>
  );
}
