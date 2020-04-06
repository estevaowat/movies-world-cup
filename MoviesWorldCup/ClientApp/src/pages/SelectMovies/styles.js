import styled from "styled-components";

export const Container = styled.div``;

export const Header = styled.div`
  display: flex;
  flex-direction: column;
  align-self: center;
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
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    grid-gap: 15px;
`;

export const Movie = styled.div`
  display: flex; 
  align-items: center;
  background: #fff;
  padding: 10px 15px;

  input { 
    background: transparent;
    border: 0;
    margin-bottom: 8px;
    font-size: 14px;
    display: flex;
    outline: 0;
    color: #9B9B9B;
    margin-right: 8px;
    cursor: pointer;
    textAlign: left;

  }

  div {
    margin-left: 15px;

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

export const Loading = styled.div`
 margin-top: 25px;
    display: flex;
    align-items: center;
    justify-content: center;
     animation: pulse 2s infinite;

@keyframes pulse {
	0% {
		transform: scale(0.8);
	 
	}

	70% {
		transform: scale(1);
 
	}

	100% {
		transform: scale(0.8); 
	}
}


`;



export const EmptyMovies = styled.div`
    margin-top: 25px;
    display: flex;
    align-items: center;
    justify-content: center;

    strong {
        font-size: 22px;
        color: #fff;
    }
`
