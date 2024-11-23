import express, { Request, Response } from "express";
import checkInOut from "./routes/checkInOut.routes";
import roomsRoutes from "./routes/rooms.routes";

const app = express();

const PORT = 3000;

// Middlewares
app.use(express.json());

// Routes
app.use("/api/checkInOut", checkInOut);
app.use("/api/rooms", roomsRoutes);

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});
