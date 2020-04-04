import React, { useState, useEffect, useMemo } from "react";

import { Container, Header, Controls, MoviesList, Movie } from "./styles";

export default function SelectMovies() {
  const [movies, setMovies] = useState([]);
  const checkedMovies = useMemo(() => {
    return movies.filter(props => props.checked).length;
  }, [movies]);

  useEffect(() => {
    const apiReponseData = [
      {
        id: "tt3606756",
        titulo: "Os Incríveis 2",
        ano: 2018,
        nota: 8.5
      },
      {
        id: "tt4881806",
        titulo: "Jurassic World: Reino Ameaçado",
        ano: 2018,
        nota: 6.7
      },
      {
        id: "tt5164214",
        titulo: "Oito Mulheres e um Segredo",
        ano: 2018,
        nota: 6.3
      },
      {
        id: "tt7784604",
        titulo: "Hereditário",
        ano: 2018,
        nota: 7.8
      },
      {
        id: "tt4154756",
        titulo: "Vingadores: Guerra Infinita",
        ano: 2018,
        nota: 8.8
      },
      {
        id: "tt5463162",
        titulo: "Deadpool 2",
        ano: 2018,
        nota: 8.1
      },
      {
        id: "tt3778644",
        titulo: "Han Solo: Uma História Star Wars",
        ano: 2018,
        nota: 7.2
      },
      {
        id: "tt3501632",
        titulo: "Thor: Ragnarok",
        ano: 2017,
        nota: 7.9
      },
      {
        id: "tt2854926",
        titulo: "Te Peguei!",
        ano: 2018,
        nota: 7.1
      },
      {
        id: "tt0317705",
        titulo: "Os Incríveis",
        ano: 2004,
        nota: 8.0
      },
      {
        id: "tt3799232",
        titulo: "A Barraca do Beijo",
        ano: 2018,
        nota: 6.4
      },
      {
        id: "tt1365519",
        titulo: "Tomb Raider: A Origem",
        ano: 2018,
        nota: 6.5
      },
      {
        id: "tt1825683",
        titulo: "Pantera Negra",
        ano: 2018,
        nota: 7.5
      },
      {
        id: "tt5834262",
        titulo: "Hotel Artemis",
        ano: 2018,
        nota: 6.3
      },
      {
        id: "tt7690670",
        titulo: "Superfly",
        ano: 2018,
        nota: 5.1
      },
      {
        id: "tt6499752",
        titulo: "Upgrade",
        ano: 2018,
        nota: 7.8
      }
    ];

    const data = apiReponseData.map(movie => ({
      ...movie,
      checked: false
    }));

    setMovies(data);
  }, []);

  function handleChangeCheckbox(e) {
    if (checkedMovies >= 8) return;
    const data = movies.map(movie => {
      return movie.id === e.target.name
        ? { ...movie, checked: !movie.checked }
        : movie;
    });

    setMovies(data);
  }

  function handleGenerateChampionship() {
    const data = movies.filter(movie => movie.checked);

    console.log(data);

    if (checkedMovies < 8) {
      alert("Voce precisa escolher 8 filmes para gerar um campeonato");
    }
  }

  return (
    <Container>
      <Header>
        <h3>CAMPEONATO DE FILMES</h3>
        <h1>Fase de Seleção</h1>
        <span>---</span>
        <p>
          Selecione 8 filmes que voce deseja que entrem na competição e depois
          pressione o botão Gerar meu Campeonato para prosseguir.
        </p>
      </Header>
      <Controls>
        <div>
          <span>Selecionados</span>
          <span>{checkedMovies} de 8 filmes</span>
        </div>
        <button onClick={handleGenerateChampionship}>
          Gerar meu Campeonato
        </button>
      </Controls>
      <MoviesList>
        {movies.map((movie, index) => (
          <Movie key={movie.id}>
            <input
              type="checkbox"
              name={movie.id}
              checked={movie.checked}
              onChange={handleChangeCheckbox}
            />
            <div>
              <p>{movie.titulo}</p>
              <span>{movie.ano}</span>
            </div>
          </Movie>
        ))}
      </MoviesList>
    </Container>
  );
}
