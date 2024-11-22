import express, { Request, Response } from "express";
import roomsRoutes from "./routes/rooms.routes";

const app = express();

const PORT = 3000;

// Middlewares
app.use(express.json());

// Routes
app.use("/api/rooms", roomsRoutes);

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});
