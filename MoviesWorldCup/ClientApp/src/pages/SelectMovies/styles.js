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
  display: flex;
  justify-content: space-between;
  align-items: center;
  color: #fff;
  margin-top: 30px;

  button {
    border: 0;
    border-radius: 4px;
    background: #343434;
    padding: 15px;
    color: #fff;
    font-size: 16px;
    font-weight: bold;
  }
  span {
    display: block;
    font-size: 20px;
    font-weight: bold;
  }
`;

export const MoviesList = styled.div`
  margin-top: 15px;
  display: grid;
  grid-template-columns: repeat(4, 1fr);

  div {
    background: #fff;
    margin: 0 10px 10px 0;
    padding: 10px 15px;

    p {
      display: block;
      font-weight: bold;
    }

    span {
      font-size: 12px;
      color: #666;
    }
  }
`;
