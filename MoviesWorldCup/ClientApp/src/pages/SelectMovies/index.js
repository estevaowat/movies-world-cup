import React, { useState, useEffect, useMemo } from 'react';
import api from '../../services/api';
import history from '../../services/history';
import { toast } from 'react-toastify';
import Checkbox from '@material-ui/core/Checkbox';

import {
    Container,
    Header,
    Controls,
    MoviesList,
    Movie,
    Loading,
    EmptyMovies
} from './styles';

export default function SelectMovies() {
    const [movies, setMovies] = useState([]);
    const [loading, setLoading] = useState(false);
    const checkedMovies = useMemo(
        () => {
            return movies.filter(props => props.checked).length;
        },
        [movies]
    );

    useEffect(() => {
    

        async function loadMovies() {
            setLoading(true);
            const response = await api.get('api/movie');
            const data = response.data.map(movie => ({
                ...movie,
                checked: false
            }));
            setMovies(data);
            setLoading(false);
        }

        loadMovies();
   
    }, []);

    function handleChangeCheckbox(e) {
        if (checkedMovies >= 8) return;

        const data = movies.map(movie => {
            return movie.id === e.target.id
                ? { ...movie, checked: !movie.checked }
                : movie;
        });

        setMovies(data);
    }

    async function handleGenerateChampionship() {
        const moviesSelected = movies.filter(movie => movie.checked);

        if (checkedMovies < 8) {
            toast.error(
                '🚫 Você precisa escolher 8 filmes para gerar um campeonato!'
            );

            return;
        }

        try {
            const response = await api.post('api/Championship', moviesSelected);

            history.push('/resultado', {
                winners: response.data
            });
        } catch (error) {
            toast.error("Erro ao buscar filmes, favor tente novamente.")
        }
    }

    return (
        <Container>
            <Header>
                <h3>CAMPEONATO DE FILMES</h3>
                <h1>Fase de Seleção</h1>
                <span>---</span>
                <p>
                    Selecione 8 filmes que voce deseja que entrem na competição
                    e depois pressione o botão Gerar meu Campeonato para
                    prosseguir.
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

            {loading && (
                <Loading>
                    <strong>Carregando...</strong>
                </Loading>
            )}

            {!loading && movies.length > 0 ? (
                <MoviesList>
                    {movies.map(movie => (
                        <Movie key={movie.id}>

                            <Checkbox
                                defaultChecked
                                color="default"
                                checked={movie.checked}
                                onChange={handleChangeCheckbox}
                                id={movie.id}
                            />
                            <div>
                                <p>{movie.titulo}</p>
                                <span>{movie.ano}</span>
                            </div>
                        </Movie>
                    ))}
                </MoviesList>
            ) : (
                <EmptyMovies>
                    <strong>
                        Nenhum filme foi encontrado. Atualize a página
                    </strong>
                </EmptyMovies>
            )}
        </Container>
    );
}
