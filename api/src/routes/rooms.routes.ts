import { Router } from "express";
import { verifyToken } from "../middlewares/verification.middleware";
import { RoomsController } from "../controllers/rooms.controller";

const router: Router = Router();

// #region Create / Update
router.post("/", verifyToken, RoomsController.Save);
// router.put('/:id', RoomsController.updateUser);
// #endregion

// #region Read
router.get("/:keyword", verifyToken, RoomsController.Get1000);
router.get("/", verifyToken, RoomsController.Get1000);
// router.get('/:id', RoomsController.getUserById);
// #endregion

// #region Delete
router.delete("/:id", verifyToken, RoomsController.Delete);
// #endregion

import { Request, Response } from "express";
router.get("/get", (req: Request, res: Response) => {
  res.status(200);
});

export default router;
