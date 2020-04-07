import React from "react";
import history from "../../services/history";
import { Container, Header, Controls, MoviesList, Movie } from "./styles";

export default function Result({ location }) {
    const { winners } = location.state;

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
                {winners.map((winner, index) => <Movie key={winner.id}>
                    <span>{index + 1} </span>
                    <p>{winner.titulo}</p>
                </Movie>)}

            </MoviesList>
        </Container>
    );
}
