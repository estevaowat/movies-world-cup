import axios from "axios";

const api = axios.create({
    baseURL: "http://localhost:55129"
});

export default api;
