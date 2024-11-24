require("dotenv").config();
import { Request, Response } from "express";
import jwt from "jsonwebtoken";
import db from "../database";
import { LoginModel } from "../models/login.model";

export class LoginController {
  // #region Create / Update
  static async GenJWT(req: Request, res: Response) {
    const login: LoginModel = req.body;

    if (!login.id || !login.password) {
      res.status(400).send("Invalid Credentials");
      return;
    }

    let query = `SELECT id FROM tblusers WHERE id = ? AND dPassword = ?;`;
    let inserts = [login.id, login.password];
    try {
      // Run the query to fetch all users
      const [rows] = await db.execute(query, inserts);
      const json = JSON.stringify(rows);

      if (json === "[]") {
        res.status(401).send("Unauthorized");
        return;
      }

      const payload = {
        id: login.id,
      };

      const token = jwt.sign(payload, process.env.JWT_SECRET, {
        expiresIn: "1h",
      });

      // Respond with the users
      res.status(200).send(token);
    } catch (err) {
      console.error("Error creating token:", err);
      res.status(500).send("Error creating token");
    }
  }
  // #endregion
}
