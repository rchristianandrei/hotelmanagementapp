import { Router } from "express";
import { verifyToken } from "../../middlewares/verification.middleware";
import { UsersController } from "./users.controller";

const router: Router = Router();

// #region Create / Update
router.post("/", verifyToken, UsersController.Save);
// router.put('/:id', RoomsController.updateUser);
// #endregion

// #region Read
router.get("/:keyword", verifyToken, UsersController.Get1000);
router.get("/", verifyToken, UsersController.Get1000);
// router.get('/:id', RoomsController.getUserById);
// #endregion

// #region Delete
router.delete("/:id", verifyToken, UsersController.Delete);
// #endregion

export default router;
