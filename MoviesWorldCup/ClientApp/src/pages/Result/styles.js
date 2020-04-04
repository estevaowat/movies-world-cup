import styled from "styled-components";

export const Container = styled.div``;

export const Header = styled.div`
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;

  background: #6e6e6e;
  border-radius: 4px;
  color: #fff;
  margin-top: 50px;
  height: 250px;
  padding: 0 15px;

  h3 {
    color: #7b7b7b;
    font-weight: bold;
  }

  p {
    font-size: 16px;
    font-weight: bold;
    text-align: center;
  }
`;

export const Controls = styled.div`
  margin: 15px;
  display: flex;
  justify-content: flex-end;

  button {
    border: 0;
    border-radius: 4px;
    background: #343434;
    padding: 15px;
    color: #fff;
    font-size: 16px;
    font-weight: bold;
  }
`;

export const MoviesList = styled.div``;

export const Movie = styled.div`
  display: flex;
  background: #fff;
  margin-bottom: 10px;
  border-radius: 4px;

  span {
    border-radius: 4px;
    background: #6e6e6e;
    align-items: center;
    padding: 15px;
    color: #fff;
    font-size: 20px;
    font-weight: bold;
  }

  p {
    padding: 15px;
    font-size: 16px;
  }
`;
